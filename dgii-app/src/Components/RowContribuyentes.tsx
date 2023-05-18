import React, { useState } from 'react';
import { Comprobante } from '../Types/Comprobante';
import { getData } from '../Services/GenericService';
import TableCell from '@mui/material/TableCell';
import TableRow from '@mui/material/TableRow';
import TableBody from '@mui/material/TableBody';
import IconButton from '@mui/material/IconButton';
import { Contribuyente } from '../Types/Contribuyente';
import KeyboardArrowDownIcon from '@mui/icons-material/KeyboardArrowDown';
import KeyboardArrowUpIcon from '@mui/icons-material/KeyboardArrowUp';
import Box from '@mui/material/Box';
import Collapse from '@mui/material/Collapse';
import Typography from '@mui/material/Typography';
import TablePaginationWrapper from './TablePaginationWrapper';
import TableComprobantes from './TableComprobantes';
import { ClipLoader } from 'react-spinners';
import { ResponseComprobante } from '../Types/ResponseComprobante';

interface RowProps {
  Contribuyente: Contribuyente;
}

const RowContribuyentes: React.FC<RowProps> = ({ Contribuyente }) => {
  const [open, setOpen] = useState(false);
  const [Comprobantes, setComprobantes] = useState<Comprobante[]>([]);
  const [count, setCount] = useState(0);
  const [isLoading, setIsLoading] = useState(false);
  const { rncCedula } = Contribuyente;
  
  const fetch = async (page: number, rowsPerPage: number) => {
    setIsLoading(true);
    const response = await getData<ResponseComprobante>(`Comprobantes/${rncCedula}`, page + 1, rowsPerPage);
    if (response) {
      setComprobantes(response.items);
      setCount(response.count);
    }
    setIsLoading(false);
  }
  
  const handleCollapse = async (open: boolean): Promise<void> => {
    if (!open) {
      fetch(0, 5);
    }
    setOpen(!open);
  } 
    
  return (
    <React.Fragment>
      <TableRow>
        <TableCell>
          <IconButton
            aria-label="expandir"
            size="small"
            onClick={() => handleCollapse(open)}
          >
            {open ? <KeyboardArrowUpIcon /> : <KeyboardArrowDownIcon />}
          </IconButton>
        </TableCell>
        <TableCell align="center">{Contribuyente.rncCedula}</TableCell>
        <TableCell align="center">{Contribuyente.nombre}</TableCell>
        <TableCell align="center">{Contribuyente.tipo}</TableCell>
        <TableCell align="center">{Contribuyente.estado}</TableCell>
        <TableCell align="center">{Contribuyente.totalItebis}</TableCell>
      </TableRow>
      <TableRow>
        <TableCell style={{ paddingBottom: 0, paddingTop: 0 }} colSpan={6}>
          <Collapse in={open} timeout="auto" unmountOnExit>
            <Box sx={{ margin: 1, width: '100%' }}>
              <Typography variant="h6" gutterBottom component="div">
                Comprobantes
              </Typography>
            <TablePaginationWrapper 
              count={count} 
              onChangeEvent={(page: number, rowsPerPage: number) => fetch(page, rowsPerPage)}
              >
              { isLoading ? 
            <TableBody>
              <TableRow>
                  <TableCell align="center" colSpan={3}>
                    <ClipLoader
                      color={"#36d7b7"}
                      loading={isLoading}
                      size={30}
                      aria-label="Loading Spinner"
                      data-testid="loader"
                    />
                  </TableCell>
              </TableRow>
            </TableBody>
          : 
          <TableComprobantes Comprobantes={Comprobantes} />
        }
            </TablePaginationWrapper>
            </Box>
          </Collapse>
        </TableCell>
      </TableRow>
    </React.Fragment>
  );
}
export default RowContribuyentes;