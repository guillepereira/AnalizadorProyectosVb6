# Analizador de Proyectos de Visual Basic 6 (.NET 9)

**AnalizadorProyectosVb6** es una aplicación de escritorio moderna desarrollada en C# que actúa como un motor de análisis estático de código (Static Code Analysis). El objetivo principal de este sistema es automatizar la ingesta, lectura, mapeo y depuración de proyectos de gran envergadura desarrollados en Visual Basic 6.0, sirviendo como base fundamental para la extracción de requerimientos y su posterior migración hacia arquitecturas ágiles en .NET.

---

## 🎯 Objetivos del Proyecto

El proyecto está diseñado para cumplir un flujo estratégico dividido en dos grandes metas:

1. **Depuración y Limpieza (Código Muerto):** Identificar con precisión matemática qué variables, constantes, funciones, formularios y módulos se ejecutan realmente en el sistema original y cuáles constituyen "código muerto", permitiendo una depuración total previa a la migración.
2. **Ingeniería Inversa y Requerimientos:** Analizar la estructura limpia y útil para identificar algoritmos críticos, flujos de negocio y dependencias, generando la documentación técnica necesaria para construir una nueva aplicación nativa en C# bajo las mejores prácticas actuales.

---

## 📊 Características del Proyecto VB6 a Analizar (Línea Base)
La aplicación está preparada para procesar proyectos complejos de VB6 con volumetrías exigentes, tomando como base inicial un sistema con las siguientes características y contenidos:
* **Tipo:** Exe Camaleón / Estándar
* **Componentes:** Formularios (`.frm`), Módulos (`.bas`), Clases de Usuario (`.cls`) y Controles de Usuario (`.ctl`).
* **Dependencias:** Referencias lógicas y Objetos/Controles ActiveX (`.ocx`).
* **Complejidad:** Declaraciones mixtas de ámbitos (Global, Public, Private, Dim) a nivel de módulo, locales y tipos definidos por el usuario (`Type`).

---

## 🛠️ Arquitectura y Tecnologías Utilizadas

Para garantizar un rendimiento óptimo al procesar cientos de miles de líneas de código y millones de nodos sintácticos, se seleccionó una infraestructura moderna y robusta:

* **Runtime & UI:** `.NET 9.0` (Windows Forms Desktop) aprovechando las mejoras de rendimiento de memoria, procesamiento de texto eficiente (`Span<T>`) y recolección de basura de última generación.
* **Analizador Sintáctico (Parsing):** `ANTLR4` (Another Tool for Language Recognition) mediante los paquetes *Antlr4.Runtime.Standard* y *Antlr4BuildTasks*, utilizando gramáticas optimizadas para interpretar la sintaxis exacta de VB6.
* **Gestión de Dependencias y Llamadas:** `QuikGraph` para la construcción y recorrido del grafo de llamadas (*Call Graph*).
* **Bitácora y Trazabilidad:** `Serilog` para el registro estructurado de eventos y excepciones sintácticas.
* **Patrón de Diseño:** Separación estricta entre **BackEnd** (Servicios de parsing y modelos de datos fuertemente tipados) y **FrontEnd** (UI responsiva basada en eventos y asincronismo `async/await`).

---

## 🗺️ Plan de Desarrollo por Fases

El proyecto se ejecuta de forma secuencial y ordenada a través de las siguientes etapas:

* [x] **Preliminares:** Configuración de infraestructura, integración de gramáticas ANTLR4 en .NET 9, diseño base de UI y validación de compilación limpia.
* [ ] **Fase 1: Ingesta y Mapeo del Archivo de Proyecto (.vbp):** Lectura secuencial del archivo del proyecto, inventariado de componentes y construcción del explorador jerárquico multi-proyecto en un control `TreeView`. Separación de metadata visual de código fuente plano.
* [ ] **Fase 2: Análisis de Ámbitos (Scopes) y Visibilidad:** Mapeo de variables y constantes globales, públicas, privadas y locales a lo largo del ciclo de vida del software.
* [ ] **Fase 3: Análisis de Referencias Cruzadas (Análisis de Uso):** Implementación de algoritmos de recorrido de grafos para enlazar invocaciones y detectar componentes huérfanos.
* [ ] **Fase 4: Reporte de Depuración e Impacto:** Consolidación de listas de elementos obsoletos y análisis de código no ejecutable.
* [ ] **Fase 5: Extracción de Lógica de Negocio para Requerimientos:** Exportación de estructuras de datos limpias a formatos legibles para la planificación del nuevo sistema en C#.

---

## 📁 Estructura del Repositorio
```text
AnalizadorProyectosVb6/
├── Formularios/       # Interfaces de usuario y pantallas del FrontEnd (MenuPrincipal, ExploradorProyectos, etc.)
├── Grammar/           # Archivos de gramática ANTLR4 (.g4) para Lexer y Parser de VB6
├── Models/            # Modelos de datos del BackEnd (Vb6Project, Vb6Component, etc.)
├── Services/          # Motores lógicos, parsers de archivos y procesadores del BackEnd
└── RecursosGraficos/  # Íconos, imágenes y clases de pruebas generales de la infraestructura
```
