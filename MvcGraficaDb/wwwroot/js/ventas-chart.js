const canvas = document.getElementById("ventasChart");

if (canvas && window.ventasData) {
    new Chart(canvas, {
        type: "bar",
        data: {
            labels: window.ventasData.meses,
            datasets: [{
                label: "Ventas RD$",
                data: window.ventasData.totales,
                backgroundColor: "#2563eb",
                borderColor: "#1d4ed8",
                borderWidth: 1,
                borderRadius: 6
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            plugins: {
                legend: {
                    display: false
                },
                tooltip: {
                    callbacks: {
                        label: context => `RD$ ${Number(context.raw).toLocaleString("es-DO")}`
                    }
                }
            },
            scales: {
                y: {
                    beginAtZero: true,
                    ticks: {
                        callback: value => `RD$ ${Number(value).toLocaleString("es-DO")}`
                    }
                }
            }
        }
    });
}
