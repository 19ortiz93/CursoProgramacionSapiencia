Algoritmo sin_titulo
	//Un individuo desea invertir su capital en un 
	//banco y desea saber cuánto dinero ganará después 
	//de un mes, si el banco paga a razón de n% mensual.
	
	Definir  interes, capital, ganancia como real;
	
	//Entradas
	Escribir "Ingrese el capital a invertir: ";
	Leer capital;
	Escribir "Ingrese el interes del banco mensual: ";
	Leer interes;
	//Proceso
	// 2.5/100 = 0.025 -- inteses/100 -- 0-1 0% a 100%
	ganancia = (interes/100) * capital;
	
	//salida -> Escribir - Imprimir - Mostrar 
	Imprimir "La ganancia mensual es: " + ConvertirATexto(ganancia) + " Pesos";
FinAlgoritmo
