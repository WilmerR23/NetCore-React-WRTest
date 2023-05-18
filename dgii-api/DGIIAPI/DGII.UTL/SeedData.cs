using DGII.BOL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.UTL
{
    public class SeedData
    {   // Metodos Seed para cargar data dummy a la base de datos
        public static IEnumerable<Contribuyente> GetContribuyentes()
        {
            return new Contribuyente[] {
                    new Contribuyente
                    {
                        Id = 1,
                        EstadoId = 1,
                        Nombre = "JUAN PEREZ",
                        rncCedula = "98754321012",
                        TipoId = 1,
                    },
                    new Contribuyente
                    {
                        Id = 2,
                        EstadoId = 2,
                        Nombre = "FARMACIA TU SALUD",
                        rncCedula = "123456789",
                        TipoId = 2,
                    },
                    new Contribuyente
                    {
                        Id = 3,
                        EstadoId = 1,
                        Nombre = "Jose Perez",
                        rncCedula = "123876879",
                        TipoId = 1,
                    },
                    new Contribuyente
                    {
                        Id = 4,
                        EstadoId = 2,
                        Nombre = "COLMADO FULANITO",
                        rncCedula = "89239473",
                        TipoId = 2,
                    },
                    new Contribuyente
                    {
                        Id = 5,
                        EstadoId = 1,
                        Nombre = "EDDY GRULLON",
                        rncCedula = "1245484796",
                        TipoId = 1,
                    },
                    new Contribuyente
                    {
                        Id = 6,
                        EstadoId = 2,
                        Nombre = "DGII",
                        rncCedula = "56677867866",
                        TipoId = 2,
                    },
                    new Contribuyente
                    {
                        Id = 7,
                        EstadoId = 1,
                        Nombre = "CARLOS MENA",
                        rncCedula = "5567733467",
                        TipoId = 1,
                    },
                    new Contribuyente
                    {
                        Id = 8,
                        EstadoId = 2,
                        Nombre = "MARIANO TERRERO",
                        rncCedula = "5611675673",
                        TipoId = 2,
                    },
                    new Contribuyente
                    {
                        Id = 9,
                        EstadoId = 1,
                        Nombre = "EDWARD CRUZ",
                        rncCedula = "3111245454",
                        TipoId = 1,
                    },
                    new Contribuyente
                    {
                        Id = 10,
                        EstadoId = 2,
                        Nombre = "LA SIRENA",
                        rncCedula = "4442888566",
                        TipoId = 2,
                    },
                    new Contribuyente
                    {
                        Id = 11,
                        EstadoId = 1,
                        Nombre = "DIANA RIVAS",
                        rncCedula = "45345345236",
                        TipoId = 1,
                    },
                    new Contribuyente
                    {
                        Id = 12,
                        EstadoId = 2,
                        Nombre = "SALON JOSEFINA",
                        rncCedula = "66565657443",
                        TipoId = 2,
                    }
                };
        }
        public static IEnumerable<Comprobante> GetComprobantes()
        {
            return new Comprobante[] {
                    new Comprobante
                    {
                        Id = 1,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000001",
                        rncCedula = "98754321012",
                        ContribuyenteId = 1
                    },
                    new Comprobante
                    {
                        Id = 2,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000002",
                        rncCedula = "98754321012",
                        ContribuyenteId = 1
                    },
                    new Comprobante
                    {
                        Id = 3,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000003",
                        rncCedula = "98754321012",
                        ContribuyenteId = 1
                    },
                    new Comprobante
                    {
                        Id = 4,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000004",
                        rncCedula = "98754321012",
                        ContribuyenteId = 1
                    },
                    new Comprobante
                    {
                        Id = 5,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000005",
                        rncCedula = "98754321012",
                        ContribuyenteId = 1
                    },
                    new Comprobante
                    {
                        Id = 6,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000006",
                        rncCedula = "98754321012",
                        ContribuyenteId = 1
                    },
                    new Comprobante
                    {
                        Id = 7,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000007",
                        rncCedula = "98754321012",
                        ContribuyenteId = 1
                    },
                    new Comprobante
                    {
                        Id = 8,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000008",
                        rncCedula = "123456789",
                        ContribuyenteId = 2
                    },
                    new Comprobante
                    {
                        Id = 9,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000009",
                        rncCedula = "123456789",
                        ContribuyenteId = 2
                    },
                    new Comprobante
                    {
                        Id = 10,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000010",
                        rncCedula = "123456789",
                        ContribuyenteId = 2
                    },
                    new Comprobante
                    {
                        Id = 11,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000011",
                        rncCedula = "123456789",
                        ContribuyenteId = 2
                    },
                    new Comprobante
                    {
                        Id = 12,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000012",
                        rncCedula = "123456789",
                        ContribuyenteId = 2
                    },
                    new Comprobante
                    {
                        Id = 13,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000013",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    },
                    new Comprobante
                    {
                        Id = 14,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000014",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    },
                    new Comprobante
                    {
                        Id = 15,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000015",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    },
                    new Comprobante
                    {
                        Id = 16,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000016",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    },
                    new Comprobante
                    {
                        Id = 17,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000017",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    },
                    new Comprobante
                    {
                        Id = 18,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000018",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    },
                    new Comprobante
                    {
                        Id = 19,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000019",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    },

                    new Comprobante
                    {
                        Id = 20,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000020",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    },
                    new Comprobante
                    {
                        Id = 21,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000021",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    },
                    new Comprobante
                    {
                        Id = 22,
                        Itbis18 = new decimal(36.00),
                        Monto = new decimal(200.00),
                        Ncf = "E310000000022",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    },
                    new Comprobante
                    {
                        Id = 23,
                        Itbis18 = new decimal(180.00),
                        Monto = new decimal(1000.00),
                        Ncf = "E310000000023",
                        rncCedula = "123876879",
                        ContribuyenteId = 3
                    }
                };
        }
        public static IEnumerable<EstadoContribuyente> GetEstados()
        {
            return new EstadoContribuyente[] {
                    new EstadoContribuyente
                    {
                        Id = 1,
                        Nombre = "Activo"
                    },
                    new EstadoContribuyente
                    {
                        Id = 2,
                        Nombre = "Inactivo"
                    }
            };
        }
        public static IEnumerable<TipoContribuyente> GetTipos()
        {
            return new TipoContribuyente[] {
                    new TipoContribuyente
                    {
                        Id = 1,
                        Nombre = "PERSONA FISICA"
                    },
                    new TipoContribuyente
                    {
                        Id = 2,
                        Nombre = "PERSONA JURIDICA"
                    }
            };
        }
    }
}
