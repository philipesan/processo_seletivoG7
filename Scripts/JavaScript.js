const $input = document.querySelector('[data-js="input"]')
$input.addEventListener('input', handleInput, false)

function handleInput(e) {
    e.target.value = mascaraTelefone(e.target.value)
}

function mascaraTelefone(telefone) {
    return telefone.replace(/\D/g, '')
        .replace(/^(\d)/, '($1')
        .replace(/^(\(\d{2})(\d)/, '$1) $2')
        .replace(/(\d{5})(\d{2,6})/, '$1-$2')
        .replace(/(-\d{4})\d+?$/, '$1');
}