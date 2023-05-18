import axios, { AxiosInstance } from 'axios';
import Swal from 'sweetalert2';
const axiosClient: AxiosInstance = axios.create({
  baseURL: `https://localhost:7026/api`,
  headers: {
    Accept: 'application/json',
    'Content-Type': 'application/json'
  },
  timeout: 30000
});

// axiosClient.interceptors.response.use(
//   (res) => {
//     return res;
//   },
//   async (err) => {
//     if (err.status === 500) { // Si el server retorna un error 500, mostrar mensaje al usuario
//       Swal.fire("Error", "Ha ocurrido un error, favor contactar al departamento de quejas de la dgii", "error");
//     } else if (err.response) {
//         console.log(err.response.data);
//       } else if (err.request) {
//         console.log(err.request);
//       } else {
//         // Algo paso al preparar la petición que lanzo un error
//         console.log('Error', err.message);
//       }

//     return Promise.reject(err);
//   }
// );

export { axiosClient };
