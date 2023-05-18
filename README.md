# NetCore-React-WRTest
Proyecto de prueba con Net Core como lenguaje backend y React como parte del frontend.

# Pasos para probar api
1 - Colocar su servidor local en el connectionString del archivo appsettings  
2 - Ejecutar el comando update-database en el proyecto DGII.DAL para aplicar el migration file actual 
3 - Ejecutar script '1.0 - Create Table Logs' que se encuentra en el root del repositorio
4 - Ejecutar proyecto, automaticamente se inicializara swagger en el navegador.

# Pasos para probar web app
1 - Seguir las intrucciones del apartado 'Pasos para probar api'
2 - Abrir VSCode y ejecutar el comando npm install en el folder dgii-app
3 - Ejecutar npm start para inicializar la web app
