$(document).ready(function () {

    $('#txtCEP').inputmask('99999-999');

    $('#btnPesquisar').click(function (event) {

        var jsonViaCEP = 'https://viacep.com.br/ws/' + $('#txtCEP').val() + '/json';

        $.getJSON(jsonViaCEP, function (data) {

            $("#lblCEP").text(data['cep']);
            $("#lblLogradouro").text(data['logradouro']);
            $("#lblComplemento").text(data['complemento']);
            $("#lblBairro").text(data['bairro']);
            $("#lblLocalidade").text(data['localidade']);
            $("#lblUF").text(data['uf']);
            $("#lblUnidade").text(data['unidade']);
            $("#lblIBGE").text(data['ibge']);
            $("#lblGIA").text(data['gia']);

        });

    });

});