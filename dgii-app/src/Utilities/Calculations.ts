import { Comprobante } from '../Types/Comprobante';

export const getTotalItebis = (Comprobantes: Comprobante[]): number => {
  return Comprobantes.reduce((prev, current) => {
    return prev + current.itbis18;
  }, 0);
};
