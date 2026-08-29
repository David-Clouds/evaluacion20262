# 🔧 TecnoGas Hogar — Portal de Solicitudes de Servicio Técnico

> Aplicación web MVC en .NET 10 para registrar y consultar solicitudes de servicio técnico de la empresa ficticia **TecnoGas Hogar**, evaluación del Ciclo 2026-2.

![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)
![EF Core](https://img.shields.io/badge/EF%20Core-SQLite-003B57?logo=sqlite&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-ready-2496ED?logo=docker&logoColor=white)
![Render](https://img.shields.io/badge/Deploy-Render-46E3B7?logo=render&logoColor=white)

---

## 🔗 Enlaces

| Recurso | URL |
|---|---|
| 📦 Repositorio GitHub | https://github.com/David-Clouds/evaluacion20262 |
| 🌐 Aplicación en Render | https://evaluacion20262-9dz7.onrender.com |

---

## 🛠️ Tecnologías

- **.NET 10** (ASP.NET Core MVC)
- **Entity Framework Core** + **SQLite**
- **Docker** (build multi-stage)
- **Git / GitHub** (ramas, Pull Requests, merges)
- **Render** (despliegue como Web Service)

---

## ✨ Funcionalidades

- ✅ **Registrar** una nueva solicitud de servicio (Insert), con validaciones de campos obligatorios.
- ✅ **Listar** las solicitudes registradas (Select), ordenadas por fecha de registro descendente.

---

## 🗃️ Modelo de datos

**`SolicitudServicio`**

| Campo | Tipo | Descripción |
|---|---|---|
| `Id` | int | Identificador autogenerado |
| `Cliente` | string | Nombre del cliente |
| `Telefono` | string | Teléfono de contacto |
| `Distrito` | string | Distrito del servicio |
| `TipoServicio` | string | Instalación, Mantenimiento, Revisión, Fuga |
| `Descripcion` | string? | Detalle adicional (opcional) |
| `FechaRegistro` | DateTime | Fecha y hora del registro |

---

## 💻 Cómo correr localmente

```bash
cd TecnoGas.Web
dotnet restore
dotnet ef database update
dotnet run
```

Abre **http://localhost:8080/** — te redirige directo al listado de solicitudes.

---

## 🚀 Despliegue en Render

La aplicación está desplegada como **Web Service** en Render usando el `Dockerfile` incluido en la raíz del repositorio.

| Configuración | Detalle |
|---|---|
| Runtime | Docker |
| Rama desplegada | `main` |
| Puerto | Variable de entorno `PORT` (provista por Render, leída en `Program.cs`) |
| Base de datos | SQLite (`tecnogas.db`), no versionada en Git — se crea y migra automáticamente al iniciar con `db.Database.Migrate()` |

---

## 🌳 Estructura de ramas (Git)
main
└── develop
├── feature/modelo-sqlite → Pregunta 1: entidad + EF Core + SQLite
├── feature/registro-solicitud → Pregunta 2: formulario + Insert
└── feature/listado-solicitudes → Pregunta 3: listado + Select

Cada rama `feature/` se integró a `develop` mediante **Pull Request** y **merge**. Al finalizar, `develop` se fusionó a `main`.

---

## 📋 Entregables

1. Repositorio en GitHub con ramas, Pull Requests y merges visibles.
2. Aplicación publicada y accesible en Render.