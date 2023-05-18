import { AxiosRequestConfig } from 'axios';
import { axiosClient } from './API';

export const getData = async <T>(
  endpoint: string,
  pageNumber: number,
  rowsPerPage: number
): Promise<T | undefined> => {
  try {
    const config: AxiosRequestConfig = {
      method: 'GET',
      url: `/${endpoint}?rowsPerPage=${rowsPerPage}&pageNumber=${pageNumber}`
    };
    const res = await axiosClient<T>(config);

    return res.data;
  } catch (error) {
    console.log(error);
  }
};
