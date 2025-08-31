¡Ah, perfecto! Entonces este README sería la **primera parte del proyecto**, enfocada en la funcionalidad básica de **gestión de empleados**, acceso a base de datos y exportación a archivo de texto.

Podemos dejarlo más claro para reflejar que es solo la **Parte 1 del Proyecto “Kiosco La Esquina”**, así cualquier lector o docente sabe que hay futuras ampliaciones (como ventas, productos, estadísticas, etc.). Te lo reescribo adaptado:

---

# Kiosco La Esquina – Parte 1

## Descripción

Esta es la **Primera Parte** del proyecto **Kiosco La Esquina**, desarrollada en **C# Windows Forms** como parte del **Trabajo Práctico Obligatorio 1**.
En esta etapa, la aplicación permite gestionar los **empleados** del kiosco mediante:

* **Acceso y manipulación de base de datos Access**.
* **Manejo de errores y validaciones**.
* **Exportación de datos a archivos de texto**.
* **Interacción básica con el usuario** a través de cuadros de diálogo (`MessageBox`, `SaveFileDialog`).

---

## Funcionalidades de la Parte 1

1. **Visualización de empleados**

   * Lista de empleados en un `DataGridView`.
   * Mensaje inicial indicando la cantidad de empleados actuales.

2. **Alta de nuevos empleados**

   * Campos: Nombre, Apellido, DNI, Cargo.
   * Validaciones:

     * Campos obligatorios.
     * Evita duplicar DNI.
   * Manejo de errores mediante **Try-Catch**.

3. **Exportación a archivo de texto**

   * Permite guardar la lista de empleados en un archivo `.txt`.
   * Confirmación de éxito o error mediante `MessageBox`.

4. **(Extra) Búsqueda rápida**

   * Filtro por apellido en tiempo real usando un `TextBox`.

---

## Tecnologías Utilizadas

* **C# Windows Forms**
* **ADO.NET (OleDbConnection, OleDbCommand, OleDbDataAdapter)**
* **Microsoft Access (.mdb)**
* **.NET Framework 4.8** o compatible

---


## Instalación y Uso

1. Abrir `KioscoLaEsquina.sln` con Visual Studio.
2. Verificar que `Empleados.mdb` esté en la carpeta del proyecto.
3. Ejecutar la aplicación (F5).
4. **Agregar empleados** completando los TextBox y clic en “Agregar Empleado”.
5. **Guardar en archivo** clic en “Guardar en Archivo” y elegir ubicación.
6. **Búsqueda rápida**: escribir apellido para filtrar empleados.

---

## Manejo de Errores y Validaciones

* Bloques **Try-Catch** en operaciones con base de datos.
* Mensajes claros ante errores de inserción o guardado.
* Validaciones de campos vacíos y DNI duplicado.

---

## Autor

**Nahuel Gigena**
Trabajo Práctico Obligatorio 1 – Acceso a Bases de Datos y Manejo de Errores


