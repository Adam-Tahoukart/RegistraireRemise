// Fichier javascript general pour la recherche, les details ouvrables et les appels ajax
$.ajaxSetup({
    contentType: "application/x-www-form-urlencoded; charset=UTF-8",
    beforeSend: function (xhr) {
        xhr.overrideMimeType("text/html; charset=UTF-8");
    }
});

$(document).ready(function () {
    SummaryHandling();
    $('.dropdown-item.item-layout').on('click', function (e) {
        if ($(e.target).is('a')) return;
        const href = $(this).find('a').attr('href');
        if (href) window.location = href;
    });
});

// Surligne la recherche
function highlightSearch(search) {
    if (!search || search.trim() === '') return;
    search = search.trim().toLocaleLowerCase().normalize('NFD').replace(/[\u0300-\u036f]/g, '');
    $('.pageContent').find('.StudentListLayout, .CoursesListLayout, .TeacherListLayout').each(function () {
        highlight(search, $(this)[0]);
    });
}

// Ajoute le ctrl clic
function SummaryHandling() {
    $('summary').attr('title', 'Utilisez ctrl-clic pour developper/reduire');
    $('summary').off();
    $('summary').on('click', function (e) {
        if (e.ctrlKey) {
            if ($(this).parent().attr('open') != undefined) {
                $('details').removeAttr('open');
                e.preventDefault();
            } else {
                $('details').prop('open', true);
                e.preventDefault();
            }
        }
    });
}

// Sauvegarde le fichier json
function RestoreDetailsState() {
    $("details").off();
    $("details").on('toggle', function () {
        let details_dom = $(this)[0];
        if (details_dom != undefined) {
            localStorage.setItem(details_dom.id, details_dom.open);
        }
    });
    for (let i = 0; i < localStorage.length; i++) {
        const key = localStorage.key(i);
        if (key.indexOf("details") > -1) {
            let details_dom = $("#" + key)[0];
            if (details_dom != undefined)
                details_dom.open = localStorage.getItem(key) == "true";
        }
    }
}

$(".submitCmd").click(function () {
    $("form").submit();
});

// Appelle une action en ajax
function ajaxActionCall(actionLink) {
    $.ajax({
        url: actionLink,
        method: 'GET',
        success: (data) => {
            console.log("Result: " + data);
        }
    });
}

let minKeywordLenth = 1;
// Surligne le texte trouve
function highlight(text, elem) {
    text = text.trim();
    if (text.length >= minKeywordLenth) {
        var innerHTML = elem.innerHTML;
        let startIndex = 0;
        while (startIndex < innerHTML.length) {
            var normalizedHtml = innerHTML.toLocaleLowerCase().normalize('NFD').replace(/[\u0300-\u036f]/g, '');
            var index = normalizedHtml.indexOf(text, startIndex);
            let highLightedText = "";
            if (index >= startIndex) {
                highLightedText = "<span class='highlight'>" + innerHTML.substring(index, index + text.length) + "</span>";
                innerHTML = innerHTML.substring(0, index) + highLightedText + innerHTML.substring(index + text.length);
                startIndex = index + highLightedText.length + 1;
            } else
                startIndex = innerHTML.length + 1;
        }
        elem.innerHTML = innerHTML;
    }
}
