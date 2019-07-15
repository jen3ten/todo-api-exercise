export default function ToDo(todos){
    return `
        <ol>
            ${todos.map(todo => {
                return `
                <li>
                    <h3>${todo}</h3>
                </li>
                `
            }).join('')
        }
        </ol>
    `
}