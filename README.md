
# Titulo work in progress




## Resumen


La funcionalidad de la aplicacion depende del tipo de usuario con el que inicies, si el tipo de usuario es "usuario" solo podras ver estadisticas historicas, vuelos disponibles (ver su informacion y pasajeros) y vender un pasaje a estos vuelos.
El usuario administrador puede hacer lo mismo que un usuario mas la posibilidad de programar vuelos y hacer ABM de usuarios.


Para acceder al programa se puede usar el boton de autocompletar que te trae un usuario aleatorio (si se quiere acceder con el administrador, el usuario es "pepe" y la contraseña "pepe").
Una vez iniciado podemos visualizar los vuelos disponibles, si queremos ver mas informacion seleccionamos y vamos a "mas informacion", tambien podemos vender un pasaje y ver los pasajeros del vuelo seleccionado.
Podemos agregar clientes directamente desde el menu principal.
El boton "vender" solo aparece si se selecciona un vuelo que pueda vender pasajes (es decir que el estado sea distinto a lleno o en vuelo) y el boton "pasajeros" solo aparece si se selecciona un vuelo.
En la pestaña de vender pasaje, primero hay que elegir un cliente que vaya a comprar los pasajes, se puede buscar con el buscador por nombre/apellido/dni, si el cliente no esta registrado podemos agregarlo con el boton "agregar cliente".
Una vez elegido el cliente podemos elegir la cantidad de pasajes que va a comprar y abajo nos mostrara el nombre del cliente que va a comprar los pasajes.Si se elije mas de un pasaje
a medida que se vayan cargando los pasajeros se mostrara su nombre en el recuadro que se encuentra en el medio, una vez cargado todos los pasajeros te mostrara una ultima vez los mismos con el precio final a pagar.
En la pestaña agregar vuelo, hay que llenar los distintos campos, la lista de aviones solo te muestra los aviones disponibles segun la fecha, si este avion tiene un vuelo programado en ese dia, no aparece.
En la pestaña de pasajeros podemos ver la informacion de los pasajeros cargados de ese vuelo.
El boton historico lleva a distintas estadisticas que se puede ver en el combo box. Podemos visualizar:



- Destinos: Todos los destinos, total facturado y cantidad de pasajeros que viajaron(ordenado por facturacion de manera descendente).

- Clientes Frecuentes: Se considera cliente frecuente a todo aquel que haya comprado mas de 2 pasajes.

- Ganancias Totales: Muestra todos los vuelos que se hicieron, clasificados en cabotaje o internacional segun corresponda.

- Vuelos Finalizados: Muestra todos los vuelos finalizados.

- Aviones: Muestra la informacion de todos los aviones.

- Vendedores: si es un usuario normal, muestra cierta informacion sobre los demas vendedores, si es un usuario administrador tambien permite hacer ABM de los mismos.



###Diagrama


![imgen](Matias.Barrozo.Parcial/diagrama.png)