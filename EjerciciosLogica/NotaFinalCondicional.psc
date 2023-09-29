Algoritmo sin_titulo
	//Leer tres notas de un estudiante, promediar su nota final,
	//si la nota es mayor a 3.5 Aprueba la materia de contrario Reprueba la materia.
	Definir nota1, nota2, nota3, notaFinal Como Real;
	//Entradas
	Escribir "Ingrese la primer nota: ";
	Leer nota1;
	Escribir "Ingrese la segunda nota: ";
	Leer nota2;
	Escribir "Ingrese la tercera nota: ";
	Leer nota3;
	//Proceso 
	notaFinal = (nota1+nota2+nota3)/3;
	//Proceso con salida
	si notaFinal > 3.5 Entonces
		Escribir "Aprobo la materia en: " +ConvertirATexto(notaFinal);
	SiNo
		Escribir "Reprobo la materia en: "+ConvertirATexto(notaFinal);
	FinSi
FinAlgoritmo
