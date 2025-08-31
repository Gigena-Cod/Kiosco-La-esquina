�Ah, perfecto! Entonces este README ser�a la **primera parte del proyecto**, enfocada en la funcionalidad b�sica de **gesti�n de empleados**, acceso a base de datos y exportaci�n a archivo de texto.

Podemos dejarlo m�s claro para reflejar que es solo la **Parte 1 del Proyecto �Kiosco La Esquina�**, as� cualquier lector o docente sabe que hay futuras ampliaciones (como ventas, productos, estad�sticas, etc.). Te lo reescribo adaptado:

---

# Kiosco La Esquina � Parte 1

## Descripci�n

Esta es la **Primera Parte** del proyecto **Kiosco La Esquina**, desarrollada en **C# Windows Forms** como parte del **Trabajo Pr�ctico Obligatorio 1**.
En esta etapa, la aplicaci�n permite gestionar los **empleados** del kiosco mediante:

* **Acceso y manipulaci�n de base de datos Access**.
* **Manejo de errores y validaciones**.
* **Exportaci�n de datos a archivos de texto**.
* **Interacci�n b�sica con el usuario** a trav�s de cuadros de di�logo (`MessageBox`, `SaveFileDialog`).

---

## Funcionalidades de la Parte 1

1. **Visualizaci�n de empleados**

   * Lista de empleados en un `DataGridView`.
   * Mensaje inicial indicando la cantidad de empleados actuales.

2. **Alta de nuevos empleados**

   * Campos: Nombre, Apellido, DNI, Cargo.
   * Validaciones:

     * Campos obligatorios.
     * Evita duplicar DNI.
   * Manejo de errores mediante **Try-Catch**.

3. **Exportaci�n a archivo de texto**

   * Permite guardar la lista de empleados en un archivo `.txt`.
   * Confirmaci�n de �xito o error mediante `MessageBox`.

4. **(Extra) B�squeda r�pida**

   * Filtro por apellido en tiempo real usando un `TextBox`.

---

## Tecnolog�as Utilizadas

* **C# Windows Forms**
* **ADO.NET (OleDbConnection, OleDbCommand, OleDbDataAdapter)**
* **Microsoft Access (.mdb)**
* **.NET Framework 4.8** o compatible

---


## Instalaci�n y Uso

1. Abrir `KioscoLaEsquina.sln` con Visual Studio.
2. Verificar que `Empleados.mdb` est� en la carpeta del proyecto.
3. Ejecutar la aplicaci�n (F5).
4. **Agregar empleados** completando los TextBox y clic en �Agregar Empleado�.
5. **Guardar en archivo** clic en �Guardar en Archivo� y elegir ubicaci�n.
6. **B�squeda r�pida**: escribir apellido para filtrar empleados.

---

## Manejo de Errores y Validaciones

* Bloques **Try-Catch** en operaciones con base de datos.
* Mensajes claros ante errores de inserci�n o guardado.
* Validaciones de campos vac�os y DNI duplicado.

---

## Autor

**Nahuel Gigena**
Trabajo Pr�ctico Obligatorio 1 � Acceso a Bases de Datos y Manejo de Errores


