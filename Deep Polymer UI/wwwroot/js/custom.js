// Sidebar Toggle Interactivity for PMR Management Layout
document.addEventListener('click', (event) => {
    const hamburger = event.target.closest('.hamburger-btn');
    if (hamburger) {
        document.body.classList.toggle('sidebar-collapsed');
    }
});
