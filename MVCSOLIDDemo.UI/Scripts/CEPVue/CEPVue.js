var cepVue = new Vue({
    el: '#appCep',
    data: {
        cep:'',
        logradouro:'',
        complemento:'',
        bairro:'',
        localidade:'',
        uf:'',
        unidade:'',
        ibge:'',
        gia:''
    },
    methods: {
        consultarCep: function () {
            var jsonViaCEP = 'https://viacep.com.br/ws/' + $('#txtCEP').val() + '/json';

            http.request({
                url: jsonViaCEP,
                method: "GET",
                headers: { "Content-Type": "application/json" }               
            }).then(response => {
               data = response.content.toJSON();
            }, error => {
                console.error(error);
            });
            
        }
    }

})