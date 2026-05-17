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

Como testar a Function de Ponto Eletrônico

```
curl -X POST https://bater-ponto-oqqio3oqkq-rj.a.run.app -H "Content-Type: application/json" -d "{\"Type\":\"IN\",\"TimePunched\":\"2026-05-17T11:20:00-03:00\",\"ImageBase64\":null,\"ShiftType\":\"REGULAR\",\"Latitude\":-23.5505,\"Longitude\":-46.6333}"
```

Exemplo de Payload

```
{
  "Type": "IN",
  "TimePunched": "2026-05-17T11:20:00-03:00",
  "ImageBase64": null,
  "ShiftType": "REGULAR",
  "Latitude": -23.5505,
  "Longitude": -46.6333
}

```

Resposta esperada

```
StatusCode Content
---------- -------
       200
```

Justificativa da Arquitetura

Funcionalidade escolhida: registro de ponto (bater ponto) via requisições HTTP com payload contendo tipo, horário, turno e geolocalização.

Essa funcionalidade é melhor aproveitada como Cloud Function porque tem execução curta e sob demanda, com picos pontuais (entradas/saídas) e longos períodos ociosos. Em serverless, o provisionamento e a escala são automáticos, reduzindo custo operacional quando não há tráfego e permitindo crescer sem gerenciamento de infraestrutura. Além disso, o deploy isolado evita acoplamento com a API existente, diminui o risco de regressões e permite evolução independente do endpoint de ponto.
