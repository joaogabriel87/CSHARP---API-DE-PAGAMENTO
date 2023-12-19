# API de Pagamento
Esta API RESTful permite cadastrar cartões e chaves Pix para transações de pagamento.

## Métodos Disponíveis
### 1. Cadastrar Cartão
Endpoint: /api/cadastrar-cartao

Método: POST

JSON de Exemplo:

```
{
  "NumeroCartao": "seu_numero_cartao_aqui",
  "DataValidade": "2023-12",
  "CodigoSeguranca": "seu_codigo_seguranca_aqui"
}
```
### Tratamento de Erros:

- 400 Bad Request: Requisição inválida (por exemplo, formato de data inválido).
- Número do cartão inválido (deve conter exatamente 16 números).
- Código de segurança inválido (deve conter exatamente 3 números).

### 2. Cadastrar Chave Pix
Endpoint: /api/cadastrar-pix

Método: POST

JSON de Exemplo:

```
{
  "ChavePix": "CPF",
  "numeroPix": "seu_numero_pix_aqui",
  "Valor": 100.00
}
```
### Tratamento de Erros:

- 400 Bad Request: Requisição inválida (por exemplo, valor inválido).
- CPF inválido (deve conter exatamente 11 dígitos numéricos).
- Telefone inválido (deve conter exatamente 11 dígitos numéricos).
- Email inválido (deve conter '@').
- Chave do Pix inválida.
