$(document).ready(function(){    

    $("#CreateGameButton").on("click", CreateGame);
});

function StartGame() {
}

function CreateGame() {
    var players = $("#NumberOfPlayers").val();
    if (players < 2) {
        alert("You can't play with less than two players!");
        return;
    }
    $.ajax(
        {
            url: "/Game/Create",
            data:
                {
                    Players: players
                },
            success: function (result) {
                $("#PlayerInformation").html(result);
            }
        }
        );
}