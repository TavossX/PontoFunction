Inicializa e configura a CLI pela primeira vez.

```
gcloud init
```

Faz login na conta Google.

```
gcloud auth login
```

Cria um novo projeto.

```
gcloud projects create NOME_DO_PROJETO
```

Define o projeto padrão.

```
gcloud config set project ID_DO_PROJETO
```

Deploy da função
```
 gcloud functions deploy bater-ponto `
  --runtime=dotnet10 `
  --trigger-http `
  --allow-unauthenticated `
  --entry-point=PontoFunction.PontoGcFunction `
  --region=southamerica-east1 `
  --min-instances=0 `
  --max-instances=5
```
