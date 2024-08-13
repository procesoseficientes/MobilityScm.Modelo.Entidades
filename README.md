## Modelo SQL Lite
Para publicar el paquete correr el siguiente comando:
```bash
gpr push bin/Release/MobilityScm.Modelo.Entidades.<version actual del paquete>.nupkg -k <GITHUB PAT>
```

Updated:
```bash
dotnet nuget push "bin/Release/MobilityScm.Modelo.Entidades.<version actual del paquete>.nupkg" --source "https://nuget.pkg.github.com/procesoseficientes/index.json" -k <GITHUB PAT>
```
