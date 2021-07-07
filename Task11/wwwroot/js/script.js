var submitionPage;

async function show(ID) {
    submitionPage = document.getElementById('submition-' + ID);
    submitionPage.style.display = 'block';
}

async function accept() {
    submitionPage.style.display = 'none';
}

async function decline() {
    submitionPage.style.display = 'none';
}