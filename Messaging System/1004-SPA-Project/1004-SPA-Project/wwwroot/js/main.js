document.addEventListener('DOMContentLoaded', function () {
    // page navigation and dynamic content loading
    fetch('/api/datga')
        .then(response => response.json())
        .then(data => {
            // Update the content of the #app element with the fetched data
            const appElement = document.getElementById('app');
            appElement.innerHTML = data.join('<br>');
            console.log("Fetch success.")
        })
        .catch(error => console.error('Error fetching data:', error));
});