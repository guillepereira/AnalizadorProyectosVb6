# Analizador de Proyectos VB6

<p align="center">
  <img src="https://img.shields.io/badge/.NET-9.0-512BD4?logo=dotnet&logoColor=white" alt=".NET 9" />
  <img src="https://img.shields.io/badge/Windows-WinForms-0078D6?logo=windows&logoColor=white" alt="Windows Forms" />
  <img src="https://img.shields.io/badge/ANTLR-4-5D2E8C" alt="ANTLR 4" />
  <img src="https://img.shields.io/badge/Estado-En%20desarrollo-orange" alt="Estado en desarrollo" />
</p>

AnalizadorProyectosVb6 es una herramienta de análisis estático para proyectos desarrollados en Visual Basic 6 (VB6), pensada para ayudar a comprender, depurar y documentar sistemas heredados antes de migrarlos, modernizarlos o reestructurarlos.

La aplicación está diseñada para procesar proyectos complejos de VB6, identificar componentes realmente ejecutados, detectar código muerto, reconstruir dependencias y extraer información útil para la ingeniería inversa y la documentación técnica.

## Objetivo principal

Este proyecto busca responder dos preguntas clave sobre un sistema VB6:

1. Qué partes del código realmente se ejecutan y cuáles son innecesarias o no activadas.
2. Cómo está organizado el sistema, qué lógica de negocio contiene, cuáles son sus dependencias y qué elementos deben revisarse antes de una migración o refactorización.

Para ello, combina análisis sintáctico, modelado de dependencias, recorrido de grafos y una interfaz gráfica basada en Windows Forms.

## ¿Qué hace esta herramienta?

- Analiza proyectos VB6 compuestos por formularios, módulos, clases y controles de usuario.
- Reconoce archivos de proyecto (.vbp) y estructura de componentes.
- Parsea código VB6 con ANTLR4 para extraer identificadores, declaraciones y estructuras sintácticas.
- Identifica ámbitos y visibilidad de variables, constantes y funciones.
- Detecta llamadas, referencias cruzadas y posibles dependencias entre elementos.
- Genera un mapa de ejecución y lógica útil para depuración y análisis de impacto.
- Sirve como base para documentación técnica y extracción de requisitos sobre sistemas heredados.

## Stack tecnológico

- .NET 9.0 + Windows Forms
- C#
- ANTLR4 para parsing del lenguaje VB6
- QuickGraph para modelado y recorrido de grafos de llamadas
- Serilog para trazabilidad y logs de análisis
- Visual Studio / SDK .NET moderno

## Arquitectura del proyecto

La solución está pensada para separar claramente la lógica de análisis del frontend visual:

- FrontEnd: formularios Windows Forms para explorar el proyecto, visualizar resultados y navegar el árbol de componentes.
- BackEnd: motores de análisis, parsing y extracción de estructuras de datos.
- Grammar: definiciones ANTLR4 para lexer y parser de VB6.
- Models: representación de entidades del proyecto, archivos, componentes y referencias.
- Services: lógica de análisis, carga de proyectos y procesamiento de dependencias.

## Estado del proyecto

El proyecto se encuentra en desarrollo activo.

- [x] Infraestructura base y configuración del repositorio
- [x] Configuración de la solución en .NET 9
- [x] Integración de gramáticas ANTLR4
- [x] Estructura inicial de formularios y UI
- [ ] Ingesta y mapeo del archivo de proyecto (.vbp)
- [ ] Análisis de ámbitos y visibilidad
- [ ] Análisis de referencias cruzadas
- [ ] Reporte de depuración e impacto
- [ ] Extracción de lógica de negocio para requerimientos

## Requisitos

Antes de ejecutar la aplicación, asegúrate de tener instalado:

- Windows 10 o superior
- .NET 9 SDK
- Visual Studio 2022 o superior
- Soporte para aplicaciones de escritorio Windows Forms

## Instalación y ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/guillepereira/AnalizadorProyectosVb6.git
cd AnalizadorProyectosVb6
```

### 2. Abrir la solución

Abre la solución principal:

```bash
AnalizadorProyectosVb6.slnx
```

o bien abre la carpeta del proyecto desde Visual Studio.

### 3. Restaurar dependencias

Visual Studio restaurará automáticamente los paquetes NuGet. Si prefieres hacerlo manualmente:

```bash
dotnet restore
```

### 4. Compilar

```bash
dotnet build
```

### 5. Ejecutar

```bash
dotnet run --project AnalizadorProyectosVb6/AnalizadorProyectosVb6.csproj
```

## Estructura del repositorio

```text
AnalizadorProyectosVb6/
├── AnalizadorProyectosVb6.slnx
├── AnalizadorProyectosVb6/
│   ├── Formularios/                 # Pantallas y formularios de la interfaz
│   ├── Grammar/                     # Gramáticas ANTLR4 (lexer/parser VB6)
│   ├── Properties/                  # Recursos y configuraciones del proyecto
│   ├── RecursosGraficos/            # Recursos visuales y clases auxiliares
│   ├── App.config                  # Configuración de la aplicación
│   ├── AnalizadorProyectosVb6.csproj # Configuración del proyecto .NET
│   ├── Program.cs                  # Entrada principal de la app
│   └── ...
├── .gitignore
├── README.md
└── ...
```

## Flujo principal del proyecto

El proyecto se está diseñando para ejecutar el siguiente flujo:

1. Carga de un proyecto VB6 o de un conjunto de archivos fuente.
2. Lectura del archivo .vbp y mapeo de componentes.
3. Parseo de cada archivo VB6 con ANTLR4.
4. Extracción de declaraciones, referencias, ámbitos y dependencias.
5. Generación de un grafo de llamadas y relaciones entre componentes.
6. Identificación de elementos huérfanos, código no ejecutado o no referenciado.
7. Presentación de resultados en la interfaz y preparación para documentar requisitos o migración.

## Casos de uso previstos

- Evaluación de sistemas VB6 heredados antes de una migración.
- Reducción de riesgos durante mantenimiento y reescrituras.
- Identificación de código muerto o no accesible.
- Documentación de dependencias entre formularios, módulos y clases.
- Análisis de lógica de negocio a partir de la estructura del sistema.
- Soporte para reingeniería inversa y modernización.

## Metodología de análisis

El enfoque del proyecto combina dos dimensiones:

- Análisis sintáctico: interpretación del lenguaje VB6 para extraer estructuras útiles.
- Análisis estructural: reconstrucción del sistema a partir de dependencias, referencias y flujo de ejecución.

Esto permite no solo detectar errores o código no usado, sino también comprender mejor la lógica subyacente del sistema original.

## Roadmap

### Fase 1: Ingesta y mapeo del proyecto
- Lectura de .vbp
- Inventariado de componentes
- Exploración jerárquica del proyecto

### Fase 2: Análisis de ámbitos y visibilidad
- Variables globales, públicas, privadas y locales
- Constantes y scope analysis

### Fase 3: Análisis de referencias cruzadas
- Grafos de llamadas
- Dependencias entre componentes
- Detección de elementos huérfanos

### Fase 4: Reporte de depuración e impacto
- Código no ejecutado
- Impactos de cambios
- Listados de elementos obsoletos

### Fase 5: Extracción de lógica de negocio
- Documentación estructural
- Identificación de algoritmos y flujos de negocio
- Preparación para migración o reescritura en .NET / C#

## Contribución

Las contribuciones son bienvenidas.

Si deseas colaborar:

1. Haz un fork del repositorio.
2. Crea una rama para tu cambio.
3. Implementa la mejora o corrección.
4. Abre un pull request describiendo el problema y la solución.

## Licencia

Este proyecto no ha definido aún una licencia pública explícita. Si este repositorio va a compartirse con otros usuarios o equipos, se recomienda definir una licencia como MIT, Apache 2.0 o GPL según el caso de uso.

## Contacto / mantenimiento

Este repositorio está orientado a uso técnico y análisis de sistemas heredados. Si quieres colaborar o evaluar el proyecto, puedes usar el repositorio de GitHub como punto de contacto principal.

## Resumen corto

AnalizadorProyectosVb6 es una solución de análisis estático para VB6 enfocada en la depuración de código heredado, la identificación de elementos no ejecutados y la extracción de conocimiento estructural útil para migración y documentación técnica.

---

Si quieres, puedo dejarte también una segunda versión de este README más orientada a GitHub (más visual, más breve y más “marketing técnico”) o una versión más técnica y académica para equipos de ingeniería.




















































































































































































































































































































































































































































































































































































