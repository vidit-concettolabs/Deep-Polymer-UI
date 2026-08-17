// Sidebar Toggle Interactivity for PMR Management Layout
document.addEventListener('click', (event) => {
    const hamburger = event.target.closest('.hamburger-btn');
    if (hamburger) {
        document.body.classList.toggle('sidebar-collapsed');
    }
});

// Horizontal Scroll Interactivity for Masters Tabs with Mouse Wheel
document.addEventListener('wheel', (event) => {
    const tabsRow = event.target.closest('.masters-tabs-row');
    if (tabsRow) {
        if (event.deltaY !== 0) {
            tabsRow.scrollLeft += event.deltaY;
            event.preventDefault();
        }
    }
}, { passive: false });
