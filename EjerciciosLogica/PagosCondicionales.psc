Algoritmo sin_titulo
	//Compra de artículos, Si los artículos comprados 
	//es menor a 3 Pagar en efectivo, caso contrario pagar con tarjeta.
	
	Definir numArticulos Como Entero;
	Definir metodoPago Como Caracter;
	
	Escribir "Ingrese el número de articulos ha comprar: ";
	Leer numArticulos;
	
	si numArticulos <= 3 Entonces
		metodoPago = "Efectivo";
	SiNo
		metodoPago = "Tarjeta";
	FinSi
	
	Escribir "Debes pagar los articulos con: " +metodoPago;
	
FinAlgoritmo
