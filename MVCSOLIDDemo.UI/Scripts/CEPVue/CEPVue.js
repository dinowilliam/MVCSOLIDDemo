var cepVue = new Vue({
    el: '#appCep',
    data() {
        return {
            data: {
                cep: '',
                logradouro: '',
                complemento: '',
                bairro: '',
                localidade: '',
                uf: '',
                unidade: '',
                ibge: '',
                gia: ''
            }
        }
    },
    methods: {
        consultarCep: function () {
            var jsonViaCEP = 'https://viacep.com.br/ws/' + $('#txtCEP').val() + '/json';

            axios
                .get(jsonViaCEP)
                .then(response => (this.data = response.data));                          

        }
    }

});