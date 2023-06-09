# NetCore-React-WRTest
Proyecto de prueba para aplicar a vacante en la DGII con Net Core como lenguaje backend y React como parte del frontend.

# Pasos para probar api
1 - Colocar su servidor local en el connectionString del archivo appsettings.  
2 - Ejecutar el comando update-database en el proyecto DGII.DAL para aplicar el migration file actual.  
3 - Ejecutar script '1.0 - Create Table Logs' que se encuentra en el root del repositorio.  
4 - Ejecutar proyecto, automaticamente se inicializara swagger en el navegador.  

# Pasos para probar web app
1 - Seguir las intrucciones del apartado 'Pasos para probar api'.  
2 - Abrir VSCode y ejecutar el comando npm install en el folder dgii-app.  
3 - Ejecutar npm start para inicializar la web app. 

# Capturas de pantalla
![Contribuyentes](Contribuyentes.PNG)  

![Comprobantes](Comprobantes.PNG) 

# Stack
Net 7  
React  
EF Core  
Material UI  
Jest  
XUnit  
Moq  
AutoMapper  
NLog  
Prettier  
