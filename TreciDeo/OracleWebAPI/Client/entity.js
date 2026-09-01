export class EntityList {
    constructor(api, endpoint, hostElement) {
        this.api = api;
        this.endpoint = endpoint;
        this.hostElement = hostElement;
        this.data = [];
    }

    async loadData() {
        this.data = await this.api.get(this.endpoint);
        this.render();
    }

    render() {
        this.hostElement.innerHTML = "";

        if (!Array.isArray(this.data) || this.data.length === 0) {
            this.hostElement.textContent = "No data.";
            return;
        }

        const table = document.createElement("table");
        table.className = "table-hover";

        const header = document.createElement("tr");
        for (const key of Object.keys(this.data[0])) {
            const th = document.createElement("th");
            th.textContent = key;
            header.appendChild(th);
        }
        table.appendChild(header);

        for (const item of this.data) {
            const row = document.createElement("tr");

            for (const key of Object.keys(this.data[0])) {
                const cell = document.createElement("td");
                const value = item[key];
                cell.textContent = value == null ? "" : String(value);
                row.appendChild(cell);
            }

            table.appendChild(row);
        }

        this.hostElement.appendChild(table);
    }
}
