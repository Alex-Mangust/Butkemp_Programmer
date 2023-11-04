class Department:
    id: int
    tittle: str

    def __init__(self, id: int, title: str) -> None:
        self.id = id
        self.tittle = title

    def __repr__(self) -> str:
        return f"title: {self.tittle} id: {self.id}"