Algoritmo sin_titulo
	//Crea un programa que pida al usuario una contraseña, 
    //mientras que no introduzca la contraseña correcta se le 
    //solicitara de forma repetitiva. 
    //Cuando finalmente escriba la contraseña correcta,
    //se le dirá "Bienvenido" y terminará el programa.
	
	Definir clave, c Como Entero;
	c = 0;
	
	Repetir
		Escribir "ingrese la contraseña: ";
		Leer clave;
		c = c + 1;
	Hasta Que clave <> 3468 Y c <= 2;
	
	Si clave <> 3468 Entonces
        Escribir "Usuario bloqueado";
    SiNo
        Escribir "Bienvenido al sistema";
    FinSi
	
FinAlgoritmo
