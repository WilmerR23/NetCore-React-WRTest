import React, { useState, useEffect } from 'react';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import { getData } from '../Services/GenericService';
import { Contribuyente } from '../Types/Contribuyente';
import RowContribuyentes from './RowContribuyentes';
import TablePaginationWrapper from './TablePaginationWrapper';
import { ClipLoader } from 'react-spinners';
import { ResponseContribuyente } from '../Types/ResponseContribuyente';

const TableContribuyentes: React.FC = () => {
  const [Contribuyentes, setContribuyentes] = useState<Contribuyente[]>([]);
  const [count, setCount] = useState(0);
  const [isLoading, setIsLoading] = useState(false);

  useEffect(() => {
      setIsLoading(true);
      fetch(0, 10).catch(console.error);
  }, []);
  
  const fetch = async (page: number, rowsPerPage: number) => {
    const response = await getData<ResponseContribuyente>("Contribuyentes", page + 1, rowsPerPage);
    if (response) {
      setContribuyentes(response.items);
      setCount(response.count);
    }
    setIsLoading(false);
  }

  return (
    <TableContainer component={Paper}>
      <TablePaginationWrapper count={count} onChangeEvent={(page: number, rowsPerPage: number) => fetch(page, rowsPerPage)}>
          <>
            <TableHead>
              <TableRow>
                <TableCell />
                <TableCell align="center">RncCedula</TableCell>
                <TableCell align="center">Nombre</TableCell>
                <TableCell align="center">Tipo</TableCell>
                <TableCell align="center">Estado</TableCell>
                <TableCell align="center">Total Itebis</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
            { isLoading ? 
              <TableRow>
                <TableCell align="center" colSpan={6}>
                  <ClipLoader
                    color={"#36d7b7"}
                    loading={isLoading}
                    size={30}
                    aria-label="Loading Spinner"
                    data-testid="loader"
                  />
                </TableCell>
              </TableRow>
            : 
              <>{Contribuyentes.map((row) => (
                <RowContribuyentes key={row.rncCedula} Contribuyente={row} />
              ))}</>
            }
            </TableBody>
          </>
      </TablePaginationWrapper>
    </TableContainer>
  );
}

export default TableContribuyentes;