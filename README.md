# netcoreapp

Incluye una aplicación simple, desarrollada con .NET Core y que expone su **DockerFile** para construir imagen de Docker, además de su **JenkinsFile** que establece el Pipeline de integración continua.

## Demos

Para hacer modificaciones de ejemplo es prefereible usar la siguiente ruta: **netcoreapp/pub/web/Views/Home/Index.cshtml**. Luego será necesario crear la nueva imagen de Docker (en el repositorio público se actualizará de forma automática).

## Docker

Para ejecutar en Docker, una vez se tenga la imagen creada y publicada en un repositorio:
```bash
docker run -d -p 8444:80 --coreapp preventa/netcoreapp
```

Para ejecutar en Docker Swarm, una vez se tenga la imagen creada y publicada en un repositorio:
```bash
docker service create --replicas 3 --name coreapp --publish 8444:80 preventa/netcoreapp
```
