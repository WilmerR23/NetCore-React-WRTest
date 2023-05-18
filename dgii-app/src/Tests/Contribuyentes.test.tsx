import { render, screen } from '@testing-library/react';
import { ResponseContribuyente } from '../Types/ResponseContribuyente';
import { getData } from '../Services/GenericService';
import TableContribuyentes from '../Components/TableContribuyentes';

jest.mock('../Services/GenericService');

it('TableContribuyente debe mostrar la lista de contribuyentes', async () => {
  const Contribuyentes = [
    {
      estado: 'Activo',
      nombre: 'JUAN PEREZ',
      rncCedula: '98754321012',
      tipo: 'Persona fisica',
      totalItebis: 500
    }
  ];
  const dataObj: ResponseContribuyente = {
    items: Contribuyentes,
    count: Contribuyentes.length
  };
  const mockedGetData = jest.mocked(getData);
  mockedGetData.mockResolvedValueOnce(dataObj);
  render(<TableContribuyentes />);
  const matched = await screen.findByText(/JUAN PEREZ/);
  expect(matched).toBeInTheDocument();
});
