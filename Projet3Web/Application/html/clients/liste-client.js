// Déclaration des variables
var tableBody = $("#table-body");
var modalEdit = $('#modalEdit');
var form = $('#formEdit');

var inputId = $('input[name="id"]');
var inputCivilite = $('input[name="civilite"]');
var inputNom = $('input[name="nom"]');
var inputPrenom = $('input[name="prenom"]');
var inputAdresse = $('input[name="adresse"]');
var inputEmail = $('input[name="email"]');
var inputTelephone = $('input[name="telephone"]');
var inputDateNaissance = $('input[name="dateNaissance"]');

function Afficher() {
    $.ajax({
        url: "/api/clients",
        success: function (clients) {
            tableBody.empty();

            if (clients.length > 0) {
                // Itération sur la liste
                for (client of clients) {
                    // Création de la ligne pour le tableau
                    var ligneClient = $('<tr class="row-data"></tr>');
                    var ligneBoutons = $('<td></td>');
                    var ligneClient1 = $('<td>' + client.Id + '</td>');
                    var ligneClient2 = $('<td>' + client.Nom + '</td>');
                    var ligneClient3 = $('<td>' + client.Prenom + '</td>');
                    var ligneClient4 = $('<td>' + client.Email + '</td>');

                    ligneClient.data('client', client);

                    // Création des boutons
                    var boutonModifier = $('<button class="btn btn-sm btn-primary"><i class="fas fa-pen"></i></button>');
                    boutonModifier.on('click', function () {
                        // Ouverture de la popup
                        var rowData = $(this).closest('tr.row-data').data('client')
                        InitialiserModification(rowData);
                    });

                    ligneBoutons.append(boutonModifier);

                    ligneClient.append(ligneBoutons);
                    ligneClient.append(ligneClient1);
                    ligneClient.append(ligneClient2);
                    ligneClient.append(ligneClient3);
                    ligneClient.append(ligneClient4);
                    tableBody.append(ligneClient);
                }
            }
        }
    })
}

function InitialiserAjout() {
    inputId.val('');
    inputCivilite.val('');
    inputNom.val('');
    inputPrenom.val('');
    inputAdresse.val('');
    inputEmail.val('');
    inputTelephone.val('');
    inputDateNaissance.val('');
    modalEdit.modal('show');
}

function InitialiserModification(rowData) {
    inputId.val(rowData.Id);
    inputCivilite.val(rowData.Civilite);
    inputNom.val(rowData.Nom);
    inputPrenom.val(rowData.Prenom);
    inputAdresse.val(rowData.Adresse);
    inputEmail.val(rowData.Email);
    inputTelephone.val(rowData.Telephone);
    inputDateNaissance.val(new Date(rowData.DateNaissance).toLocaleDateString());
    modalEdit.modal('show');
}

function Valider() {
    console.log(inputId.val());
    var creation = inputId.val() == '';

    if (creation) {
        Ajouter();
    } else {
        Modifier();
    }

}

function Ajouter() {
    // On divise la date de naissance en jour/mois/année en séparant par le caractère '/'
    var dateNaissance = inputDateNaissance.val().split('/');
    $.ajax({
        type: 'POST',
        url: '/api/clients',
        data: {
            civilite: inputCivilite.val(),
            nom: inputNom.val(),
            prenom: inputPrenom.val(),
            adresse: inputAdresse.val(),
            email: inputEmail.val(),
            telephone: inputTelephone.val(),
            dateNaissance: new Date(dateNaissance[2], dateNaissance[1] - 1, dateNaissance[0]).toUTCString()
        },
        success: function () {
            alert('Ajout effectué');
            modalEdit.modal('hide');
            Afficher();
        }
    })
}

function Modifier() {
    // On divise la date de naissance en jour/mois/année en séparant par le caractère '/'
    var dateNaissance = inputDateNaissance.val().split('/');
    $.ajax({
        type: 'PUT',
        url: '/api/clients/' + inputId.val(),
        data: {
            id: inputId.val(),
            civilite: inputCivilite.val(),
            nom: inputNom.val(),
            prenom: inputPrenom.val(),
            adresse: inputAdresse.val(),
            email: inputEmail.val(),
            telephone: inputTelephone.val(),
            dateNaissance: new Date(dateNaissance[2], dateNaissance[1] - 1, dateNaissance[0]).toUTCString()
        },
        success: function () {
            alert('Modifications effectuées');
            modalEdit.modal('hide');
            Afficher();
        }
    })
}

$(document).ready(Afficher);