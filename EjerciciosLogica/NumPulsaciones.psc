Algoritmo sin_titulo
	//Calcular el número de pulsaciones que una persona debe tener 
    //por cada 10 segundos de ejercicio, si la fórmula es: 
    //num_pulsaciones = (220 - edad)/10 
    //Leer la edad de la persona e imprimir el numero de pulsaciones.
	Definir edad Como Entero;
	Definir numPulsaciones Como Real;
	//Entradas
	Escribir "Ingrese la edad de la persona: ";
	Leer edad;
	//Proceso 
	numPulsaciones = (220 - edad) / 10;
	//salida
	Imprimir "Número de pulsaciones por cada 10 segundos es: " +ConvertirATexto(numPulsaciones);
FinAlgoritmo
