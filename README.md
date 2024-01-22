# PayAPI

Bem-vindo à documentação da PayAPI, uma aplicação de pagamento com diversos endpoints para gerenciar autenticação, bancos, boletos de pagamento e usuários.

Site: https://payapi20240122021747.azurewebsites.net/swagger/index.html

## Autenticação (Auth)

### Login
- **Método:** POST
- **Endpoint:** /api/auth/login

## Banco (Bank)

### Criar Banco
- **Método:** POST
- **Endpoint:** /api/bank/create

### Obter Código do Banco
- **Método:** GET
- **Endpoint:** /api/bank/getbankcode

### Obter Todos os Bancos
- **Método:** GET
- **Endpoint:** /api/bank/getall

## Boleto de Pagamento (PaymentSlip)

### Criar Boleto de Pagamento
- **Método:** POST
- **Endpoint:** /api/paymentslip/create

### Obter Todos os Boletos de Pagamento
- **Método:** GET
- **Endpoint:** /api/paymentslip/getall

## Usuários (Users)

### Criar Usuário
- **Método:** POST
- **Endpoint:** /api/users

### Atualizar Usuário
- **Método:** PUT
- **Endpoint:** /api/users

### Obter Todos os Usuários
- **Método:** GET
- **Endpoint:** /api/users
