$(document).ready(function(){

    $("#SubmitPlayersButton").click(StartGame);

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