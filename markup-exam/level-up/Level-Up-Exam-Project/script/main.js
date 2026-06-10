document.getElementById("close-button").onclick = function () {
    const mainSection = document.getElementById("main-section");
    const friendSection = document.getElementById("friends-section");
    mainSection.style.width = "calc(100vw - 25.9rem)";
    friendSection.style.display = "none";
};

document.getElementById("open-friends").onclick = function () {
    const mainSection = document.getElementById("main-section");
    const friendSection = document.getElementById("friends-section");
    mainSection.style.width = "calc(100vw - 63.7rem)";
    friendSection.style.display = "block";
}

window.addEventListener('resize', function () {
    const mainSection = document.getElementById("main-section");
    const friendSection = document.getElementById("friends-section");
    if(window.innerWidth < 961) {
        mainSection.style.width = '100%';
        friendSection.style.display = "none";
    }
    // else if(friendSection.style.display != "none"){
    //     mainSection.style.width = "calc(100vw - 63.7rem)";
    // }
    else {
        mainSection.style.width = "calc(100vw - 25.9rem)";
    }
})