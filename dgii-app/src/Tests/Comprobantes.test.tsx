import { render, screen } from '@testing-library/react';
import { getTotalItebis } from '../Utilities/Calculations';
import { Comprobante } from '../Types/Comprobante';
import TableComprobantes from '../Components/TableComprobantes';

const comprobantes: Comprobante[] = [
  {
    itbis18: 90,
    monto: 500,
    ncf: 'E310000000001',
    rncCedula: '98754321012'
  },
  {
    itbis18: 180,
    monto: 1000,
    ncf: 'E310000000002',
    rncCedula: '98754321012'
  },
  {
    itbis18: 1800,
    monto: 10000,
    ncf: 'E310000000003',
    rncCedula: '98754321012'
  }
];

test('test function que calcula el itebis de los comprobantes', () => {
  expect(getTotalItebis(comprobantes)).toBe(2070);
});

test('Calculo de itebis debe ser 0 cuando no existan comprobantes', () => {
  expect(getTotalItebis([])).toBe(0);
});

test('TableComprobantes debe tener mostrar texto de comprobantes no encontrados cuando no existan comprobantes', () => {
  render(
    <table>
      <TableComprobantes Comprobantes={[]} />
    </table>
  );
  const textElement = screen.getByText(
    /Esta persona no contiene comprobantes/i
  );
  expect(textElement).toBeInTheDocument();
});

test('TableComprobantes no debe tener mostrar texto de comprobantes no encontrados cuando existan comprobantes', () => {
  render(
    <table>
      <TableComprobantes Comprobantes={comprobantes} />
    </table>
  );
  const textElement = screen.queryByText(
    /Esta persona no contiene comprobantes/i
  );
  expect(textElement).not.toBeInTheDocument();
});
