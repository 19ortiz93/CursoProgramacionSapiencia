Algoritmo sin_titulo
	//Hacer un algoritmo que calcule el total a pagar por la compra de camisas. 
    //Si se compran tres camisas o más se aplica un descuento del 20% 
    //sobre el total de la compra y si son menos de tres camisas un descuento del 10%.
	Definir precio, compra, descuento, totalPagar Como Real;
	Definir cantCamisas Como Entero;
	//Entradas
	Escribir "Ingrese la cantidad de camisas a comprar: ";
	Leer cantCamisas;
	Escribir "Ingrese el precio de las camisas: ";
	Leer precio;
	//Proceso
	compra = cantCamisas * precio;
	si cantCamisas >= 3 Entonces
		descuento = 20/100; //o,2
	SiNo
		descuento = 10/100; //0.1
	FinSi
	totalPagar = compra - (compra * descuento);
	//salidas
	Imprimir "Compra inicial: "+ConvertirATexto(compra);
	Imprimir "El descuento aplicado es: "+ConvertirATexto(descuento*100)+"%";
	Imprimir "El valor del descuento es: "+ConvertirATexto(compra*descuento);
	Imprimir "El total a pagar es: "+ConvertirATexto(totalPagar);
FinAlgoritmo
