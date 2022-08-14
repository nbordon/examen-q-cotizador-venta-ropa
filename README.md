# Cotizador de Venta de Ropa
A continuación se procede a explicar el funcionamiento del cotizador.

1. Para ejecutar el Cotizador, descargue el proyecto y acceda a la carpeta ./Vista/bin/Debug y ejecute el archivo Vista.exe.
2. Se desplegara el siguiente panel:
<img src="/Diagramas/Cotizador.png" alt="cotizador de ropa"/>
3. Debe seleccionar el tipo de prenda, las características y la calidad.
4. Luego, debe indicar el precio unitario de la prenda y la cantidad a cotizar. Dicha cantidad no debe exceder el límite en stock.
5. Para ver las cotizaciones realizadas, puede ingresar al link Historial de Cotizaciones, en la esquina superior derecha.
6. El historíal mostrará una lista con todas las prendas cotizadas hasta el momento.
<img src="/Diagramas/Historial.png" alt="historial de cotizaciones"/>  
## La solución:
La solución se llevo a cabo a través del diseño del siguiente [diagrama](https://drive.google.com/file/d/1JS5lHwksy13u6dx-igInrzxTSuadURSK/view?usp=sharing):
<img src="/Diagramas/CotizadorDeVentaDeRopa_ParteC.jpg" alt="diagrama de clases"/>

## Parte F: Imprimibles
Para poder realizar una impresion sobre el historial o sobre la cotización actual, se podria desarrollar una clase Historial y junto con la clase Cotizacion implementar una interfaz IImprimible. De esta forma cada clase podría establecer la forma en la que se imprimen sus datos. Dicha solución se muestrar en el siguiente [diagrama](https://drive.google.com/file/d/1d7QtFAF5_NHhMXSJoZZapK2DdeJICz3e/view?usp=sharing) actualizado:
<img src="/Diagramas/CotizadorDeVentaDeRopa_ParteF.jpg" alt="diagrama de clases imprimible"/>