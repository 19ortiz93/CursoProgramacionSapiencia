Algoritmo sin_titulo
	//Determinar cu�ntos hombres y cuantas mujeres se encuentran en un grupo de n personas.
    //Imprimir cantidad de cada g�nero.
	
	Definir c, contH, contM, cantidad Como Entero;
	Definir genero Como Caracter;
	
	Escribir "Ingrese cantidad de personas: ";
	Leer  cantidad;
	c = 1; contH = 0; contM = 0;
	
	Mientras c <= cantidad Hacer
		Escribir "Ingrese genero F= femenino / M= masculino de la persona # "+ConvertirATexto(c);
		Leer genero;
		genero = Mayusculas(genero);
		si genero == "F" Entonces
			contM = contM + 1;
		SiNo si genero == "M" Entonces
				contH = contH + 1;
			SiNo
				Escribir "Genero no v�lido";
				c = c - 1;
			FinSi
		FinSi
		c = c + 1;
	FinMientras
	
	Escribir "El n�mero de hombres es: "+ConvertirATexto(contH);
	Escribir " y el n�mero de mujeres es: "+ConvertirATexto(contM);
FinAlgoritmo
