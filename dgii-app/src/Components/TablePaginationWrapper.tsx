import React, { useState } from "react";
import Table from '@mui/material/Table';
import TableRow from '@mui/material/TableRow';
import TableFooter from '@mui/material/TableFooter';
import TablePagination from '@mui/material/TablePagination';
import TablePaginationActions from "./TablePaginationActions";

interface Props {
    children: JSX.Element;
    count: number;
    onChangeEvent: Function;
}

const TablePaginationWrapper: React.FC<Props> = ({ children, count, onChangeEvent }) => {
  
  const [page, setPage] = useState(0);
  const [rowsPerPage, setRowsPerPage] = useState(5);

  const handleChangePage = (
    event: React.MouseEvent<HTMLButtonElement> | null,
    newPage: number,
  ) => {
    onChangeEvent(newPage, rowsPerPage);
    setPage(newPage);
  };

  const handleChangeRowsPerPage = (
    event: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>,
  ) => {
    const rowSizeOptionSelected = parseInt(event.target.value, 10);
    setRowsPerPage(rowSizeOptionSelected);
    setPage(0);
    onChangeEvent(0, rowSizeOptionSelected);
  };

    return (
      <Table size="small">
            {children}
            <TableFooter>
              <TableRow>
                  <TablePagination
                  rowsPerPageOptions={[5, 10, 25, { label: 'Todos', value: -1 }]}
                  colSpan={3}
                  count={count}
                  rowsPerPage={rowsPerPage}
                  page={page}
                  SelectProps={{
                      inputProps: {
                      'aria-label': 'registros por pagina',
                      },
                      native: true,
                  }}
                  onPageChange={handleChangePage}
                  onRowsPerPageChange={handleChangeRowsPerPage}
                  ActionsComponent={TablePaginationActions}
                  />
              </TableRow>
            </TableFooter>
      </Table>
    );
}

export default TablePaginationWrapper;
