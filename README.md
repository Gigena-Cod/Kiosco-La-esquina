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
Funcionalidades de la Parte 2
Gestión de Empleados

Mantenimiento de la funcionalidad de la Parte 1:

Visualización, alta y exportación de empleados.

Búsqueda rápida por apellido.

Validaciones y manejo de errores.

Gestión de Proveedores

Creación de proveedores
Campos: Nombre, Razón Social, CUIT, Teléfono, Dirección.
Validaciones: Campos obligatorios, CUIT único, manejo de errores.

Actualización de proveedores
Modificación de datos existentes con confirmación de cambios.

Eliminación de proveedores
Eliminación con confirmación de seguridad.

Visualización de proveedores
Listado completo en un DataGridView.

Gestión de Productos

Visualización de productos
Listado de productos asociados a proveedores (en desarrollo de futuras etapas).

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


# Kiosco La Esquina – Parte 2

## Descripción

Esta es la **Segunda Parte** del proyecto **Kiosco La Esquina**, desarrollada en C# Windows Forms como continuación del Trabajo Práctico Obligatorio 1. En esta etapa, además de la gestión de empleados, la aplicación permite manejar **proveedores** y **productos**, agregando funcionalidades de creación, actualización, eliminación y visualización.

## Funcionalidades de la Parte 2

### Gestión de Empleados

* Mantenimiento de la funcionalidad de la Parte 1:

  * Visualización, alta y exportación de empleados.
  * Búsqueda rápida por apellido.
  * Validaciones y manejo de errores.

### Gestión de Proveedores

* **Creación de proveedores**
  Campos: Nombre, Razón Social, CUIT, Teléfono, Dirección.
  Validaciones: Campos obligatorios, CUIT único, manejo de errores.
* **Actualización de proveedores**
  Modificación de datos existentes con confirmación de cambios.
* **Eliminación de proveedores**
  Eliminación con confirmación de seguridad.
* **Visualización de proveedores**
  Listado completo en un DataGridView.

### Gestión de Productos

* **Visualización de productos**
  Listado de productos asociados a proveedores (en desarrollo de futuras etapas).

### Búsqueda y filtros

* Búsqueda rápida de proveedores por nombre o CUIT.
* Filtrado en DataGridView para mejorar la experiencia del usuario.

## Tecnologías Utilizadas

* C# Windows Forms
* ADO.NET (OleDbConnection, OleDbCommand, OleDbDataAdapter)
* Microsoft Access (.mdb)
* .NET Framework 4.8 o compatible

## Instalación y Uso

1. Abrir `KioscoLaEsquina.sln` con Visual Studio.
2. Verificar que `Empleados.mdb` y `Proveedores.mdb` estén en la carpeta del proyecto.
3. Ejecutar la aplicación (F5).
4. Gestionar empleados como en la Parte 1.
5. Gestionar proveedores usando las opciones de **Agregar, Editar, Eliminar y Visualizar**.
6. Visualizar productos en el listado correspondiente (solo lectura por ahora).

## Manejo de Errores y Validaciones

* Bloques Try-Catch en operaciones con base de datos.
* Mensajes claros ante errores de inserción, actualización o eliminación.
* Validaciones de campos obligatorios y CUIT/DNI duplicados.

## Autor

Nahuel Gigena

