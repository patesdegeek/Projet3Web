function getClients() {
    var compTableBody = $("#table-body");
    $.ajax({
        url: "/api/clients",
        success: function (clients) {
            compTableBody.empty();

            if (clients.length > 0) {
                for (client of clients) {
                    var ligneClient = $("<tr></tr>");
                    var ligneClient1 = $("<td>" + client.Id + "</td>");
                    var ligneClient2 = $("<td>" + client.Nom + "</td>");
                    var ligneClient3 = $("<td>" + client.Prenom + "</td>");
                    var ligneClient4 = $("<td>" + client.Email + "</td>");
                    ligneClient.append(ligneClient1);
                    ligneClient.append(ligneClient2);
                    ligneClient.append(ligneClient3);
                    ligneClient.append(ligneClient4);
                    compTableBody.append(ligneClient);
                }
            }
        }
    })
}

$(document).ready(getClients);