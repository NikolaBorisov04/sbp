import { ApiClient } from "./api.js";
import { EntityList } from "./entity.js";

const API_BASE_URL = "https://localhost:7234";
const message = document.getElementById("message");
const content = document.getElementById("content");

const api = new ApiClient(API_BASE_URL);

message.textContent = "Baza podataka aplikacije je prikazana u tabelama ispod.";

// Samo rokate ovako sa EntityList, pa posle udaris loadData() i to je to.
const vozilaList = new EntityList(api, "/api/vozila/sve", content);
await vozilaList.loadData();

window.api = api;
window.EntityList = EntityList;
