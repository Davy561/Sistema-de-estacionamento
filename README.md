# Sistema de Estacionamento

Um sistema básico de registro de estacionamento desenvolvido em C# para praticar lógica de programação.

## 📋 Descrição

Este é um projeto simples de console que simula um sistema de estacionamento com 4 vagas disponíveis. O sistema permite cadastrar veículos, selecionar vagas e acompanhar o status das vagas ocupadas.

## 🎯 Objetivo

- Praticar conceitos básicos de programação
- Implementar lógica de controle de estado
- Trabalhar com loops e arrays
- Criar interface de console interativa

## ⚙️ Funcionalidades

- ✅ Cadastro de veículos (placa, modelo, cor, ano, combustível)
- ✅ Seleção de vagas disponíveis
- ✅ Controle de vagas ocupadas/livres
- ✅ Sistema de loop para múltiplos cadastros
- ✅ Validação de entrada do usuário
- ✅ Exibição do status atual das vagas

## 🚀 Como usar

### Pré-requisitos
- .NET SDK instalado
- Terminal/Prompt de comando

🚀 Como usar
# Clone o repositório
git clone https://github.com/seu-usuario/Sistema-de-estacionamento.git

# Entre na pasta
cd Sistema-de-estacionamento

# Execute o programa
dotnet run

3. Siga as instruções na tela:
   - Digite os dados do veículo
   - Selecione uma vaga disponível
   - Escolha se deseja cadastrar outro veículo

## 🎮 Como funciona

1. **Boas-vindas**: Sistema exibe mensagem de boas-vindas
2. **Cadastro**: Usuário informa dados do veículo
3. **Seleção de vaga**: Sistema mostra apenas vagas disponíveis
4. **Confirmação**: Vaga é marcada como ocupada
5. **Status**: Exibe situação atual de todas as vagas
6. **Loop**: Pergunta se deseja cadastrar outro veículo

## 📊 Exemplo de uso

```
======================================
Bem-vindo ao sistema de estacionamento!
======================================

Digite a placa do veículo: ABC-1234
Digite o modelo do veículo: Honda Civic
Digite a cor do veículo: Preto
Digite o ano do veículo: 2020
Digite o tipo de combustível: Flex

Vagas disponíveis:
1. Vaga 1 - Disponível
2. Vaga 2 - Disponível
3. Vaga 3 - Disponível
4. Vaga 4 - Disponível

Selecione uma vaga (1-4): 1

Vaga 1 selecionada com sucesso!

Status atual das vagas:
Vaga 1 - Ocupada
Vaga 2 - Disponível
Vaga 3 - Disponível
Vaga 4 - Disponível
```

## 🔧 Tecnologias utilizadas

- **Linguagem**: C#
- **Framework**: .NET
- **Tipo**: Aplicação Console

## 📚 Conceitos aplicados

- **Arrays**: Controle de estado das vagas
- **Loops**: `do-while` para repetição do sistema
- **Condicionais**: Validação de entrada e controle de fluxo
- **Strings**: Manipulação de entrada do usuário
- **Console**: Interface de linha de comando

## 🎓 Aprendizados

Este projeto é ideal para iniciantes que querem praticar:
- Estruturas de controle
- Manipulação de arrays
- Validação de dados
- Interface de usuário em console
- Lógica de negócio simples

## 📝 Possíveis melhorias

- [ ] Persistência de dados em arquivo
- [ ] Controle de tempo de permanência
- [ ] Cálculo de valores a pagar
- [ ] Remoção de veículos
- [ ] Interface gráfica
- [ ] Relatórios de uso

## 👨‍💻 Autor

Desenvolvido como projeto de estudo para prática de lógica de programação em C#.

## 📄 Licença

Este projeto é de uso livre para fins educacionais.

---

⭐ Se este projeto te ajudou a aprender, deixe uma estrela!
