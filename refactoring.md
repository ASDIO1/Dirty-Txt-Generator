# List of code smells:
## Code smell 1: 
	* Linea/s del code smell: Toda el Program.cs
	* Tipo de code smell: Metodo grande
	* Refactorizacion realizada: Se extrageron multiples metodos y se los distribuyo en diferentes clases 
	* Lineas de refactorizacion: 
		Se generaron las siguientes clases para tener los metodos de manera modular 
		* TextOrderExecutor
		* TextFileManager
		* ConsoleDisplayer
## Code smell 1: mostrar error
	* Linea/s del code smell: 49, 114, 149 y 181
	* Tipo de code smell: Codigo duplicado
	* Refactorizacion realizada: Se extrajo el codigo en un metodo, llamado "displayErrorMessage"
	* Lineas de refactorizacion: Clase ConsoleDisplayer, linea 26
## Code smell 2: Files List
	* Linea/s del code smell: 54, 119, 154 y 186
	* Tipo de code smell: Codigo duplicado
	* Refactorizacion realizada: Se extrajo el codigo en un metodo, llamado "displayFilesListAndMessage"
	* Lineas de refactorizacion: Clase ConsoleDisplayer, linea 31
## Code smell 3: 
	* Linea/s del code smell: Toda la clase main
	* Tipo de code smell: Clase grande
	* Refactorizacion realizada: Se creo nuevos objetos
	* Lineas de refactorizacion:
## Code smell 4: el clear al inicio de cada metodo
	* Linea/s del code smell: 71, 203
	* Tipo de code smell: Codigo duplicado
	* Refactorizacion realizada:
	* Lineas de refactorizacion:
## Code smell 5:mostrar texto generico
	* Linea/s del code smell:
	* Tipo de code smell:
	* Refactorizacion realizada:
	* Lineas de refactorizacion:
## Code smell 5: el exit del while es muy redundante
	* Linea/s del code smell:
	* Tipo de code smell:
	* Refactorizacion realizada:
	* Lineas de refactorizacion:
## Code smell 5: chosenTxt = Convert.ToInt32(Console.ReadLine()); , no es entendible
	* Linea/s del code smell:
	* Tipo de code smell:
	* Refactorizacion realizada:
	* Lineas de refactorizacion:
## Code smell 5: chosenTxt nos da a entender que la veriable es un texto cuando en realidad es un numero
	* Linea/s del code smell:
	* Tipo de code smell:
	* Refactorizacion realizada:
	* Lineas de refactorizacion: