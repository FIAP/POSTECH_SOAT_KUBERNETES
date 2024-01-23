class UserRepository {
    save(nome, email, anoNascimento) {
        const anoAtual = new Date().getFullYear();

        let idade = anoAtual - anoNascimento;

        let resultado = {
            nome: nome,
            email: email,
            idade: idade
        };

        return resultado;

    }
}

module.exports = UserRepository;