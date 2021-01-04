using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CharacterCatalog.Core.Models;
using CharacterCatalog.Core.Constants;
using CharacterCatalog.Core.Services.Interfaces;
using CharacterCatalog.Web.Models;
using CharacterCatalog.Web.Services.Interfaces;

namespace CharacterCatalog.Web.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterService _characterService;
        private readonly ISpeciesService _speciesService;
        private readonly IUploadService _uploadService;

        public CharacterController(ICharacterService characterService, ISpeciesService speciesService, IUploadService uploadService)
        {
            _characterService = characterService;
            _speciesService = speciesService;
            _uploadService = uploadService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _characterService.GetAsync());
        }

        // GET: Character/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _characterService.GetByIdAsync(id.Value);

            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // GET: Character/Create
        public async Task<IActionResult> Create()
        {
            var viewModel = new CharacterViewModel
            {
                Character = new Character(),
                Species = await _speciesService.GetAsync()
            };

            return View(viewModel);
        }

        // POST: Character/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Character, SelectedSpeciesId")] CharacterViewModel characterViewModel)
        {
            if (ModelState.IsValid)
            {
                var selectedSpecies = await _speciesService.GetByIdAsync(characterViewModel.SelectedSpeciesId);

                characterViewModel.Character.Species = selectedSpecies;

                await _characterService.CreateAsync(characterViewModel.Character);
                return RedirectToAction(nameof(Index));
            }

            characterViewModel.Species = await _speciesService.GetAsync();

            return View(characterViewModel);
        }

        // GET: Character/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _characterService.GetByIdAsync(id.Value);
            var species = await _speciesService.GetAsync();
            
            if (character == null)
            {
                return NotFound();
            }

            var model = new CharacterViewModel
            {
                Character = character,
                Species = species
            };

            return View(model);
        }

        // POST: Character/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Character, SelectedSpeciesId")] CharacterViewModel characterViewModel)
        {
            if (id != characterViewModel.Character.CharacterId ||
                !await _speciesService.SpeciesExists(characterViewModel.SelectedSpeciesId))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var updatedSpecies = await _speciesService.GetByIdAsync(characterViewModel.SelectedSpeciesId);

                characterViewModel.Character.Species = updatedSpecies;

                var updateSuccess = await _characterService.UpdateAsync(characterViewModel.Character);

                if (updateSuccess)
                {
                    return RedirectToAction("Index", "Character");
                }
                else
                {
                    return NotFound();
                }
            }
            return View(characterViewModel);
        }

        // GET: Character/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _characterService.GetByIdAsync(id.Value);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // POST: Character/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _characterService.RemoveByIdAsync(id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Upload()
        {
            if (TempData[CharacterCatalogConsts.TempDataKeys.UploadValidationMessageKey] != null)
            {
                ViewBag.Message = TempData[CharacterCatalogConsts.TempDataKeys.UploadValidationMessageKey];
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (await _uploadService.ParseDataFromFile(file))
            {
                TempData[CharacterCatalogConsts.TempDataKeys.UploadValidationMessageKey] = "File parsed successfully.";
            }
            else
            {
                TempData[CharacterCatalogConsts.TempDataKeys.UploadValidationMessageKey] = "Failed to parse file, please try again.";
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Queries()
        {
            return View(await _characterService.GetQueriesAsync());
        }
    }
}
