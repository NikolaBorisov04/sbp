import { ApiClient } from "./api.js";
import { EntityList } from "./entity.js";

const API_BASE_URL = "https://localhost:7234";
const message = document.getElementById("message");

const api = new ApiClient(API_BASE_URL);

message.textContent = "Baza podataka aplikacije je prikazana u tabelama ispod.";

const vozilaList = new EntityList(api, "/api/vozila/sve", document.getElementById("vozila"));
await vozilaList.loadData();

const korisniciList = new EntityList(api, "/Korisnici/vratiSveKorisnike", document.getElementById("korisnici"));
await korisniciList.loadData();

const rezervacijeList = new EntityList(api, "/Rezervacije/vratiSveRezervacije", document.getElementById("rezervacije"));
await rezervacijeList.loadData();

const voznjeList = new EntityList(api, "/Voznje/vratiSveVoznje", document.getElementById("voznje"));
await voznjeList.loadData();

window.api = api;
window.EntityList = EntityList;
