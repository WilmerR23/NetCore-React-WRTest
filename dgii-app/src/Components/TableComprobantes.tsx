import React from 'react';
import { Comprobante } from '../Types/Comprobante';
import Table from '@mui/material/Table';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import TableCell from '@mui/material/TableCell';
import TableBody from '@mui/material/TableBody';
import { getTotalItebis } from '../Utilities/Calculations';

interface Props {
  Comprobantes: Comprobante[];
}

const TableComprobantes: React.FC<Props> = ({ Comprobantes }) => {
  return (
    <>
      {Comprobantes.length ? (
        <>
          <TableHead>
            <TableRow>
              <TableCell align="center">Ncf</TableCell>
              <TableCell align="center">Monto</TableCell>
              <TableCell align="center">Itebis</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {Comprobantes.map((Comprobante) => (
              <TableRow key={Comprobante.ncf}>
                <TableCell align="center">{Comprobante.ncf}</TableCell>
                <TableCell align="center">{Comprobante.monto}</TableCell>
                <TableCell align="center">{Comprobante.itbis18}</TableCell>
              </TableRow>
            ))}
            <TableRow>
              <TableCell rowSpan={3} />
              <TableCell colSpan={1} align="right">
                Total (Por pagina)
              </TableCell>
              <TableCell align="center">
                <b>{getTotalItebis(Comprobantes)}</b>
              </TableCell>
            </TableRow>
          </TableBody>
        </>
      ) : (
        <TableBody>
          <TableRow>
            <TableCell>Esta persona no contiene comprobantes</TableCell>
          </TableRow>
        </TableBody>
      )}
    </>
  );
};
export default TableComprobantes;
