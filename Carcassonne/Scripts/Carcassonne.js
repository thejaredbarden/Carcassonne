$(document).ready(function(){    

    $("#CreateGameButton").on("click", CreateGame);
});

function StartGame() {
    alert("here");
    alert($("[id*=PlayerColor]").val());
}

function CreateGame() {

    StartGame();

    $.ajax(
        {
            url: "/Game/Create",
            data:
                {
                    Players: 4
                },
            success: function (result) {
                $("#PlayerInformation").html(result);
            }
        }
        );
}