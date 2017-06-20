//File used to setup various features of Materialize framework

$(document).ready(function () {
    $('.parallax').parallax();
});


// Enable navigation prompt
document.getElementById('githubnav').onclick = function () {
    window.onbeforeunload = true;
}

document.getElementById('githubicon').onclick = function () {
    window.onbeforeunload = true;
}

document.getElementById('linkedinicon').onclick = function () {
    window.onbeforeunload = true;
}

function FilterHeroes(role_filter) {
    //check if button is already active
    //highlight button if true
    //remove highlights from button and remove filters from all hero cards
    var clicked_button = document.getElementById(role_filter);
    if (clicked_button.classList.contains('active-btn'))
    {
        ResetHeroFilters(role_filter);
        ResetButtonFilters();
        return;
    }
    else
    {
        ResetButtonFilters();
        clicked_button.classList.add('active-btn');
    }

    //set classes for every hero card
    var allheroes = document.getElementsByClassName("card");
    Array.prototype.forEach.call(allheroes, function (hero) {
        if (hero.classList.contains(role_filter))
        {
            hero.classList.remove('inactive-hero');
            hero.classList.add('active-hero');
        }
        else
        {
            hero.classList.remove('active-hero');
            hero.classList.add('inactive-hero');
        }
    });
}

function ResetButtonFilters()
{
    //set classes for every hero card
    var allbuttons = document.getElementsByClassName("btn-large");
    Array.prototype.forEach.call(allbuttons, function (button) {
        if (button.classList.contains('active-btn')) {
            button.classList.remove('active-btn');
        }
    });
}

function ResetHeroFilters(role_filter)
{
    var button_to_deselect = document.getElementById(role_filter);
    button_to_deselect.classList.remove('active-btn');

    //remove active and inactive tags for every hero
    var allheroes = document.getElementsByClassName("card");
    Array.prototype.forEach.call(allheroes, function (hero) {
        hero.classList.remove('active-hero');
        hero.classList.remove('inactive-hero');
    });
}