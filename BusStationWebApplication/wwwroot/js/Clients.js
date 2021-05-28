const uri = 'api/Clients';
let clients = [];

function getClients() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayClients(data))
        .catch(error => console.error('Unable to get clients.', error));
}

function addClient() {
    const addFullNameTextbox = document.getElementById('add-fullName');
    const addTelephoneTextbox = document.getElementById('add-telephone');

    const client = {
        fullName: addFullNameTextbox.value.trim(),
        telephone: addTelephoneTextbox.value.trim(),
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(client)
    })
        .then(response => response.json())
        .then(() => {
            getClients();
            addFullNameTextbox.value = '';
            addTelephoneTextbox.value = '';
        })
        .catch(error => console.error('Unable to add client.', error));
}

function deleteClient(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getClients())
        .catch(error => console.error('Unable to delete client.', error));
}

function displayEditForm(id) {
    const client = clients.find(client => client.id === id);

    document.getElementById('edit-id').value = client.id;
    document.getElementById('edit-fullName').value = client.fullName;
    document.getElementById('edit-telephone').value = client.telephone;
    document.getElementById('editForm').style.display = 'block';
}

function updateClient() {
    const clientId = document.getElementById('edit-id').value;
    const client = {
        id: parseInt(clientId, 10),
        name: document.getElementById('edit-fullName').value.trim(),
        info: document.getElementById('edit-telephone').value.trim()
    };

    fetch(`${uri}/${clientId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(client)
    })
        .then(() => getClients())
        .catch(error => console.error('Unable to update category.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}


function _displayClients(data) {
    const tBody = document.getElementById('clients');
    tBody.innerHTML = '';


    const button = document.createElement('button');

    data.forEach(client => {
        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${client.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteClient(${client.id})`);

        let tr = tBody.insertRow();


        let td1 = tr.insertCell(0);
        let textNodeFullName = document.createTextNode(client.fullName);
        td1.appendChild(textNodeFullName);

        let td2 = tr.insertCell(1);
        let textNodeTelephone = document.createTextNode(client.telephone);
        td2.appendChild(textNodeTelephone);

        let td3 = tr.insertCell(2);
        td3.appendChild(editButton);

        let td4 = tr.insertCell(3);
        td4.appendChild(deleteButton);
    });

    clients = data;
}
