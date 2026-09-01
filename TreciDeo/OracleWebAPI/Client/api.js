export class ApiClient {
    constructor(baseUrl) {
        this.baseUrl = baseUrl.replace(/\/$/, "");
    }

    async request(path, options = {}) {
        const response = await fetch(`${this.baseUrl}${path}`, {
            headers: {
                "Content-Type": "application/json",
                ...(options.headers ?? {})
            },
            ...options
        });

        if (!response.ok) {
            const text = await response.text();
            throw new Error(`HTTP ${response.status}: ${text}`);
        }

        if (response.status === 204) {
            return null;
        }

        return response.json();
    }

    get(path) {
        return this.request(path, { method: "GET" });
    }

    post(path, body) {
        return this.request(path, {
            method: "POST",
            body: JSON.stringify(body)
        });
    }

    put(path, body) {
        return this.request(path, {
            method: "PUT",
            body: JSON.stringify(body)
        });
    }

    delete(path) {
        return this.request(path, { method: "DELETE" });
    }
}
