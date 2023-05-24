"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chat").build();

// disable send button until connection establish
document.getElementById("sendButton").disable = true;

connection.on("ReceivedMessage", (user, message) => {
    var li = document.createElement("li");
    li.innerText = `${user} say ${message}`;
    document.getElementById("messageList").appendChild(li);
});

connection.start().then(() => {
    document.getElementById("sendButton").disable = false;
}).catch((e) => {
    return console.error(e.toString());
});

document.getElementById("sendButton").addEventListener("click", (event) => {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;

    connection.invoke("SendMessage", user, message).catch((e) => {
        return console.error(e.toString());
    });
    event.preventDefault();
});