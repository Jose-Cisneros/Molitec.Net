# Molitec.Net
Aplicación Web que se complementa con Molitec hecho también para la cátedra de Diseño de sistemas 2017 en la UTNFRLP


Aplicación Web desarrollada en .Net Core MVC. 

En ella se encuentra implementado el ABM de carta de porte, vinculándola a los contratos de compra creados en la aplicación (https://github.com/Jose-Cisneros/MoliTec).

Faltaría corregir el error conceptual de pasar modelos a las vistas en vez de ViewModels, que no se hizo por falta de tiempo.

Con respecto a las bases de datos, se utilizan dos, una MySQL para el sistema creada con el diagrama de una entrega anterior, mapeada completamente
a clases usando el EntityFramework Core  (por eso hay tantas clases en el modelo que no se usan en el programa).

Y después una secundaria SQL Server hosteada en Azure (al igual que la aplicación misma) con el plan gratuito de estudiantes, 
pero que solo se encarga del manejo de los usuarios de la aplicación web, ya que el plan no tiene mucha velocidad de respuesta en su forma de prueba.
